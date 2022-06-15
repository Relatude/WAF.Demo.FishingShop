jQuery(document).ready(function ($) {
    $(".shipping, .payment").click(function () {
        const radio = $(this).children("input[type=radio]").not(":checked");
        if (radio) {
            radio.prop("checked", true);
            radio.trigger("change");
        }
    });

    $("input[type=radio][name=shipping]").change(function () {
        const cartPriceHolder = $(".total-cart-price .price-value")
        const cartPrice = parseInt(cartPriceHolder.data("price"));
        const shippingPrice = parseInt($(this).data("price"));
        cartPriceHolder.text(numberWithCommas(cartPrice + shippingPrice));
    });
});