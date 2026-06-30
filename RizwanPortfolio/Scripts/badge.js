// =============================================================
// badge.js — drives the 3D "access badge" hero interaction
// Pure vanilla JS, no 3D library required (CSS 3D transforms).
// =============================================================
(function () {
    "use strict";

    var stage = document.getElementById("badgeStage");
    var badge = document.getElementById("badge");
    if (!badge || !stage) return;

    var reduceMotion = window.matchMedia("(prefers-reduced-motion: reduce)").matches;

    var isPointerDown = false;
    var flipped = false;
    var currentX = -8, currentY = 3;   // matches the CSS idle keyframe baseline
    var targetX = -8, targetY = 3;
    var rafId = null;

    function clamp(v, min, max) { return Math.max(min, Math.min(max, v)); }

    // ---- Mouse / pointer tilt -------------------------------------------
    function onPointerMove(e) {
        if (reduceMotion) return;
        var rect = stage.getBoundingClientRect();
        var px = (e.clientX - rect.left) / rect.width;   // 0..1
        var py = (e.clientY - rect.top) / rect.height;   // 0..1

        targetY = clamp((px - 0.5) * 36, -22, 22);
        targetX = clamp((0.5 - py) * 26, -18, 18);
    }

    function onPointerLeave() {
        targetX = -8;
        targetY = 3;
    }

    function animate() {
        currentX += (targetX - currentX) * 0.08;
        currentY += (targetY - currentY) * 0.08;

        var flipDeg = flipped ? 180 : 0;
        badge.style.animation = "none"; // hand control to JS once user interacts
        badge.style.transform =
            "rotateX(" + currentX.toFixed(2) + "deg) " +
            "rotateY(" + (currentY + flipDeg).toFixed(2) + "deg)";

        rafId = requestAnimationFrame(animate);
    }

    // ---- Scroll-driven rotation (subtle, ties badge to page progress) ---
    function onScroll() {
        if (reduceMotion) return;
        var rect = stage.getBoundingClientRect();
        var viewportCenter = window.innerHeight / 2;
        var distanceFromCenter = (rect.top + rect.height / 2) - viewportCenter;
        var influence = clamp(distanceFromCenter / 40, -10, 10);
        targetY = clamp(targetY + 0, -22, 22); // keep pointer in control on desktop
        if (!isPointerDown) {
            targetX = clamp(-8 - influence * 0.3, -20, 20);
        }
    }

    // ---- Click / tap to flip the badge ------------------------------------
    function onActivate() {
        flipped = !flipped;
        badge.setAttribute("aria-pressed", flipped ? "true" : "false");
    }

    if (reduceMotion) {
        // Respect reduced motion: no idle float, no pointer tilt, but keep flip-on-click.
        badge.style.animation = "none";
        badge.style.transform = "rotateX(0deg) rotateY(0deg)";
        badge.addEventListener("click", function () {
            flipped = !flipped;
            badge.style.transform = "rotateX(0deg) rotateY(" + (flipped ? 180 : 0) + "deg)";
        });
        return;
    }

    stage.addEventListener("mousemove", onPointerMove);
    stage.addEventListener("mouseleave", onPointerLeave);
    stage.addEventListener("touchmove", function (e) {
        if (e.touches && e.touches[0]) {
            onPointerMove(e.touches[0]);
        }
    }, { passive: true });

    badge.tabIndex = 0;
    badge.setAttribute("role", "button");
    badge.setAttribute("aria-label", "Flip ID badge to see tech stack");
    badge.addEventListener("click", onActivate);
    badge.addEventListener("keydown", function (e) {
        if (e.key === "Enter" || e.key === " ") {
            e.preventDefault();
            onActivate();
        }
    });

    window.addEventListener("scroll", onScroll, { passive: true });
    animate();
})();
