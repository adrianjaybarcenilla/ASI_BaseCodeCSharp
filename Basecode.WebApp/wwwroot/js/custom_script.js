/* Author: Albrecht Christian G. Lañojan */

jQuery.easing.jswing = jQuery.easing.swing,
jQuery.extend(
    function (t) {
        t(window).on("scroll", function () {
            var logoImg = t("#logo-img");
            console.log(logoImg)
            var e = t(".navbar");
            e.length && (e.offset().top > 200 ? t(".scrolling-navbar").addClass("top-nav-collapse") : t(".scrolling-navbar").removeClass("top-nav-collapse"))
            if (e.offset().top > 230) {
                // Change the image source to the new image
                logoImg.attr("src", "/img/asi-logo-invert.svg");
            } else {
                // Change the image source back to the original image
                logoImg.attr("src", "/img/asi-logo-white.svg");
            }
        })
    }(jQuery)
)