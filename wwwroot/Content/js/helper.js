function numberWithCommas(x) {
    var parts = x.toString().split(",");
    parts[0] = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, " ");
    return parts.join(",");
}

function _handleAddToCartSuccess(context, result) {
    if (result.success) {
        const cart = $(".cart-size-counter span")
        context.animate_from_to(cart);
        if (result.value > 9) {
            cart.text("");
        } else {
            cart.text(result.value);
        }
    }
}

function _handleAddToCartError(error) {
    console.log(error);
}
