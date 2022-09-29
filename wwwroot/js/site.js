(function ($) {
    "use strict"; // Start of use strict
    
    // Collapse Navbar
    var navbarCollapse = function () {
        if ($("#mainNav").offset().top > 100) {
            $("#mainNav").addClass("navbar-shrink");
        } else {
            $("#mainNav").removeClass("navbar-shrink");
        }
    };
    // Collapse now if page is not at top
    navbarCollapse();
    // Collapse the navbar when page is scrolled
    $(window).scroll(navbarCollapse);

})(jQuery); // End of use strict


$(document).ready(function () {
    $(".change-size--more").on("click", function () {
        changeFontSize(1)
    });
    $(".change-size--less").on("click", function () {
        changeFontSize(-1)
    });
    $(".change-size--reset").on("click", function () {
        changeFontSize(0)
    });

    const savedVersion = localStorage.getItem("visually-impaired") || false;
    applyVersionSite(savedVersion);

    $(".btn-visually").on("click", function () {
        localStorage.setItem("visually-impaired", true);
        localStorage.setItem("visually-impaired-size", 16)
        applyVersionSite(true);
    });

    $(".btn-normal").on("click", function () {
        localStorage.removeItem("visually-impaired")
        localStorage.removeItem("visually-impaired-size")
        applyVersionSite(false);
    });

    function applyVersionSite(savedVersion) {
        if (savedVersion) {
            document.querySelector("html").style.fontSize = `${localStorage.getItem("visually-impaired-size")}px`
            $("html").addClass("special-version");
        } else {
            document.querySelector("html").style.fontSize = `16px`
            $("html").removeClass("special-version");
        }

    }

    
    function changeFontSize(side) {
        let currentFontSize = localStorage.getItem("visually-impaired-size") || 16;
        if (side == 1) {
            localStorage.setItem("visually-impaired-size", currentFontSize*1.1)
        } else if (side == -1) {
            localStorage.setItem("visually-impaired-size", currentFontSize / 1.1)
        } else {
            localStorage.setItem("visually-impaired-size", 16)
        }
        document.querySelector("html").style.fontSize = `${localStorage.getItem("visually-impaired-size")}px`
    }

    //let cardAnnotations = document.querySelectorAll(".card-annotation");
    //cardAnnotations.forEach(cardAnnotation => {
    //    for (let i = 1; i < cardAnnotation.children.length; i++) {
    //        console.log(cardAnnotation.children)
    //        cardAnnotation.children[i].style.display = "none";
    //    }
    //});
    let submenu = document.querySelector(".submenu");
    submenu.addEventListener("click", function () {
        this.classList.toggle("submenu--active");
    })
})


