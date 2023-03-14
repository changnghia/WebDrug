$(document).ready(() => {
    $(document).on('click', '.btn-edit', (ev) => {
        var id = ev.target.getAttribute('data-id');
        $.get('/admin/nhacungcap/suanhacungcap/' + id, (ev) => {
            var body = document.querySelector("#body");
            body.innerHTML = "";
            $('#body').append(ev);
        })
    })
    $(document).on('click', '.edit-ncc', (ev) => {
        var data = $('#form-edit').serialize();
        $.post('/admin/nhacungcap/suanhacungcap', data, (res) => {
            if (res == true) {
                toastr.success('Sửa thành công', 'Thông báo')
                getlist();
            }
            else {
                toastr.error('Sửa thất bại', 'Thông báo')
            }
        })
    })
    $(document).on('click', '#delete', (ev) => {
        var id = ev.target.getAttribute('data-id');
        $.get('/admin/nhacungcap/xoanhacungcap/' + id, (res) => {
            if (res == true) {
                alert('xóa thành công');
                getlist();
            }
            else {
                alert('xóa thất bại')
            }
        })
    })
})
function getlist() {
    $.get('/admin/nhacungcap/listdata', (ev) => {
        var body = document.querySelector("#tbody")
        body.innerHTML = "";
        $("#tbody").append(ev)
    });
}