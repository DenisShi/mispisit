
var transparentNavbarButtonClick = false;
$(function transparentNavbar() {
    $(window).on('scroll', function () {
        if ($(window).scrollTop() > 10 && (($('.navbar').hasClass('active')) == false)) {
            $('.navbar').addClass('active');
            $('.fa.fa-bars').addClass('active');
        }
        else if (($(window).scrollTop()) < 1 && (transparentNavbarButtonClick == false)) {
            $('.navbar').removeClass('active');
            $('.fa.fa-bars').removeClass('active');
        }
    });
});

function transparentNavbarButton() 
{
    $('.navbar').addClass('active');
    $('.fa.fa-bars').addClass('active');
    if (transparentNavbarButtonClick == false) {transparentNavbarButtonClick = true}
    else if (transparentNavbarButtonClick == true) {transparentNavbarButtonClick = false}
}