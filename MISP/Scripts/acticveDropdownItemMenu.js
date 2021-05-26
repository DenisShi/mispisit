$('.dropdown-item').click(function () {
    let idDropdownItem = this.id
    localStorage.setItem("idActiveItem", idDropdownItem)
})


$(document).ready(function () {
    let dropdownItems = document.getElementsByClassName('dropdown-item');
    let idActiveItem = localStorage.getItem('idActiveItem')
    for (let i = 0; i < dropdownItems.length; i++) {
        dropdownItems[i].classList.remove('active');
    }
    for (let i = 0; i < dropdownItems.length; i++) {
        if (dropdownItems[i].id == idActiveItem) {
            dropdownItems[i].classList.add('active');
        }
    }
    localStorage.removeItem('idActiveItem')

})