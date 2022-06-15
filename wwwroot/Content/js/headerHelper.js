jQuery(document).ready(function ($) {
    $(".category-dropdown").click(function () {
        var subMenu = $(this).parents(".category").children(".sub-category");
        subMenu.animate(subMenuAnimation, 200);
    });

    const subMenuAnimation = {
        height: 'toggle',
        paddingTop: 'toggle',
        paddingBottom: 'toggle',
        opacity: 'toggle'
    }

    const menuAnimation = {
        minWidth: 'toggle',
        width: 'toggle',
        paddingLeft: 'toggle',
        paddingRight: 'toggle',
        opacity: 'toggle'
    }

    $(".header-hamburger").click(function () {
        var menu = $(this).parents("header").children(".hamburger-menu");
        $(this).fadeOut();
        menu.animate(menuAnimation, 200);
    });



    $(".search-icon-mobile").click(function () {
        const searchBar = $("form[action='/partials/Search']");
        searchBar.animate(subMenuAnimation, 200);
    });

    $(".close-menu").click(closeMenu);
    $(".container, footer").click(closeMenu);

    function closeMenu() {
        var menu = $(".hamburger-menu");
        var hamburger = $(".header-hamburger");
        if (menu.css("display") != "none") {
            hamburger.fadeIn();
            menu.animate(menuAnimation, 200);
        }
    }
});