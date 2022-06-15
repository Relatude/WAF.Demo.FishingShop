jQuery(document).ready(function ($) {
    $(".hamburger").click(function () {
        $("header .links").toggleClass("hidden");
    });

    $(".action-to-cart").click(function () {
        const context = $(this);
        const id = context.data("id");
        $.ajax({
            type: 'POST',
            url: '/partials/Shop/AddToCart',
            data: { nodeId: id, quantity: 1 },
            success: function (result) { _handleAddToCartSuccess(context, result) },
            error: function (error) { _handleAddToCartError(error) }
        });
    });
});