

//js của chuyển ảnh
    var swiper = new Swiper(".home-slider", {
        spaceBetween: 30,
        centeredSlides: true,
        autoplay: {
            delay: 4000,
            disableOnInteraction: false,
        },
        pagination: {
            el: ".swiper-pagination",
            clickable: true,
        },
        loop: true,
    });
    //Tạo sự kiện Loang Web
    $(window).on('load',function(event){
        $('body').removeClass('preloading');
        $('.loading').delay(1600).fadeOut('fast');
    });
//Thanh Mũi Tên quay lại trang ban đầu
$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('#backtop').fadeIn();
        } else {
            $('#backtop').fadeOut();
        }
    });
    $('#backtop').click(function () {
        $('html, body').animate({ scrollTop: 0 }, 500);
        return false;
    });
});

//Video Khi Click vao 
function playVideo() {
    var video = document.getElementById("myVideo");
    video.src += "?autoplay=1";
}