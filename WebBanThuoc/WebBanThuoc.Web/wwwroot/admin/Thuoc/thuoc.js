$(document).ready(() => {
    $(document).on("click", '.edit-thuoc', (ev) => {
        ev.preventDefault();
        var data = $('#formEdit').serialize();
        $.post("/admin/thuoc/editthuoc", data, (res) => {
            if (res == true) {
                Swal.fire(
                    'Good job!',
                    'You clicked the button!',
                    'success'
                ).then((e) => {
                    if (e.isConfirmed) {
                    location.href='/admin/thuoc/index'
                    }
                })
            }
        })
    })
    $(document).on("click", ".js-delete", (ev) => {
        var id = ev.target.getAttribute('data-id');
        $.post('/admin/thuoc/deletethuoc/' + id, (ev) => {
            if (ev == true) {
                toastr.success('Xóa thành công', 'Thông báo')
                getlist();
            }
        })
    })
})
function getlist() {
    $.get('/admin/thuoc/listdata', (ev) => {
        var body = document.querySelector("#tbody");
        body.innerHTML = "";
        body.innerHTML = ev;
    })
}