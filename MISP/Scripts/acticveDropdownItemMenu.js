$(document).ready(function () {
    let url_string = window.location.pathname
    let dropdownItems = document.getElementsByClassName('dropdown-item');
    for (let i = 0; i < dropdownItems.length; i++) {
        dropdownItems[i].classList.remove('active');
    }
    for (let i = 0; i < dropdownItems.length; i++) {
        let item_href = $(dropdownItems[i]).attr('href');
        if (item_href == url_string) {
            dropdownItems[i].classList.add('active');
        }
    }
})