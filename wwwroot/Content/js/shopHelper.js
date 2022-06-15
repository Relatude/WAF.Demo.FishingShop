jQuery(document).ready(function ($) {

    /* UPDATE QT */
    /* ---------------------------------------------------------------- */
    $(".qt-button.add").click(function () {
        const number = $(this).siblings(".qt-number");
        let value = number.val();
        let newValue = 1;

        if (value >= 1) {
            newValue = parseInt(value) + 1
        }

        // Update the cart
        if ($(this).hasClass("update")) {
            const id = $(this).siblings(".order-item-id").val();
            const cur = $(this);
            $.ajax({
                type: 'POST',
                url: '/partials/Shop/UpdateQuantity',
                data: { nodeId: id, quantity: newValue },
                success: function (result) {
                    if (result.success) {
                        number.val(newValue);
                        $(".cart-size-counter span").text(result.value);
                        cur.parent().siblings(".price").children(".price-value").text(numberWithCommas(result.price));
                        cur.parents(".order").children(".checkout").children(".total-cart-price").children(".price-value").text(numberWithCommas(result.totalprice));
                    }
                },
                error: function (error) {
                    console.log(error);
                    number.val(value);
                }
            });
        }
        else number.val(newValue);
    });

    $(".qt-button.subtract").click(function () {
        const number = $(this).siblings(".qt-number");
        let value = number.val();

        if (value >= 2) {
            let newValue = parseInt(value) - 1;

            // Update the cart
            if ($(this).hasClass("update")) {
                const id = $(this).siblings(".order-item-id").val();
                const cur = $(this);
                $.ajax({
                    type: 'POST',
                    url: '/partials/Shop/UpdateQuantity',
                    data: { nodeId: id, quantity: newValue },
                    success: function (result) {
                        if (result.success) {
                            number.val(newValue);
                            $(".cart-size-counter span").text(result.value);
                            cur.parent().siblings(".price").children(".price-value").text(numberWithCommas(result.price));
                            cur.parents(".order").children(".checkout").children(".total-cart-price").children(".price-value").text(numberWithCommas(result.totalprice));
                        }
                    },
                    error: function (error) {
                        console.log(error);
                        number.val(value);
                    }
                });
            }
            else number.val(newValue);
        } 
    });


    /* ADD TO CART */
    /* ---------------------------------------------------------------- */
    $(".add-to-cart-button").click(function () {
        let value = $(".qt-number").val();
        if (value < 1) {
            value = 1;
        }
        const context = $(this);
        const id = $(".product-id").val();
        $.ajax({
            type: 'POST',
            url: '/partials/Shop/AddToCart',
            data: { nodeId: id, quantity: value },
            success: function (result) { _handleAddToCartSuccess(context, result) },
            error: function (error) { _handleAddToCartError(error) }
        });
    });

    /* DELETE FROM CART */
    /* ---------------------------------------------------------------- */
    $(".delete-button").click(function () {
        let cur = $(this);
        const id = cur.siblings(".qt").children(".order-item-id").val();

        $.ajax({
            type: 'POST',
            url: '/partials/Shop/RemoveFromCart',
            data: { nodeId: id },
            success: function (result) {
                if (result.success) {
                    if (result.value > 0) {
                        cur.parents(".order").children(".checkout").children(".total-cart-price").children(".price-value").text(numberWithCommas(result.totalprice));
                        cur.parents(".order-item").remove();
                        $(".cart-size-counter span").text(result.value);
                    } else {
                        $(".order").html("<div>Handlekurven er tom</div>");
                        $(".cart-size-counter span").text('');
                    }
                    
                }
            },
            error: function (error) {
                console.log(error);
            }
        });
    });
});