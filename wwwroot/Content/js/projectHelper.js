jQuery(document).ready(function ($) {
    let instance = null;

    /* Open product viewer */
    $(".project-page .project-image .show-project-products").click(function () {
        // Check if mobile or not
        if ($(this).hasClass("click")) {
            $(this).siblings(".products-container").css("display", "flex");
            $(this).parent().children(".show-project-products").css("display", "none");
        } else {
            // If mobile open Lightbox instead
            const id = $(this).siblings("img").data("id");
            createLightbox(id);
        }
    });

    /* Close product viewer */
    $(".project-page .project-image .hide-project-products").click(function () {
        $(this).parent().siblings(".show-project-products").css("display", "block");
        $(this).parent().css("display", "none");
    });


    /* Open Lightbox */
    $(".project-page .project-image img").click(function () {
        const id = $(this).data("id");
        createLightbox(id);
    });

    /* Close Lightbox with Esc */
    $(document).keyup(function (e) {
        if (e.key === "Escape") {
            if (instance != null) {
                instance.close();
            }
        }
    });

    /* Lightbox */

    function next(id) {
        //Get next domElement
        const ids = $(".modal-container .project-image").toArray().map(function (value) {
            return $(value).data("id");
        });

        const cur_index = ids.indexOf(id);
        let new_index = 0;
        if (cur_index != ids.length - 1) {
            new_index = cur_index + 1;
        }

        switchInstance(ids[new_index]);
    }

    function prev(id) {
        //Get prev domElement
        const ids = $(".modal-container .project-image").toArray().map(function (value) {
            return $(value).data("id");
        });

        const cur_index = ids.indexOf(id);
        let new_index = ids.length - 1;
        if (cur_index > 0) {
            new_index = cur_index - 1;
        }

        switchInstance(ids[new_index]);
    }

    function switchInstance(id) {
        instance.close(() => {
            createLightbox(id);
        });
    }

    function createLightbox(id) {
        const domElement = $(".project-page .modal-container .project-image." + id).clone();
        instance = basicLightbox.create(domElement[0]);
        instance.show();

        $(".project-image-modal .close-lightbox").click(function () {
            instance.close();
        });

        $(".project-image-modal .next-lightbox").click(function () {
            next(id);
        });

        $(".project-image-modal .prev-lightbox").click(function () {
            prev(id);
        });
    }
});