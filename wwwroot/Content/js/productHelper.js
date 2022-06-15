jQuery(document).ready(function ($) {
    const orgPrice = parseFloat($(".price .value").data("price"));

    function UpdatePrice() {
        let updatePrice = orgPrice;

        // Loop through selected option
        const selectedOption = $(".option-category .selected-option");
        for (let i = 0; i <= selectedOption.length - 1; i++) {
            let price = $(selectedOption[i]).children(".option-price").children(".value").data("price");
            if (price && parseFloat(price) > 0) {
                updatePrice += parseFloat(price);
            }
        }

        $(".info-container .price .value").text(numberWithCommas(updatePrice));
    }

    UpdatePrice();

    $(".option-category .options .option").click(function (event) {
        const image = $(this).children("img");
        const url = image.attr("src");
        const title = image.attr("alt");
        const price = image.data("price");

        $(this).parent(".options").children(".option").removeClass("selected");
        $(this).addClass("selected");

        const selectedOption = $(this).parents(".option-category").children(".selected-option");
        selectedOption.children("img").attr("src", url);
        selectedOption.children(".option-name").text(title);

        if (parseFloat(price) > 0) {
            selectedOption.children(".option-price").removeClass("hidden");
        } else {
            selectedOption.children(".option-price").addClass("hidden");
        }
        selectedOption.children(".option-price").children(".value").text(numberWithCommas(price));
        selectedOption.children(".option-price").children(".value").data("price", price);

        UpdatePrice();
    });
});