$(document).ready(() => {
    $(document).on('click', '.add', (ev) => {
        $.get('/admin/phanloaithuoc/addplt', (ev) => {
            var body = document.querySelector("#body");
            body.innerHTML = "";
            $('#body').append(ev);
        })
    });
    $(document).on('click', '.btn-edit', (ev) => {
        var id = ev.target.getAttribute('data-id');
        $.get('/admin/phanloaithuoc/update/' + id, (ev) => {
            var body = document.querySelector("#body");
            body.innerHTML = "";
            $('#body').append(ev);
        })
    })
    $(document).on('click', '.add-edit', () => {
        var id = document.querySelector('.id').value;
        if (id == '') {
            var data = $('#formadd').serialize();
            $.post('/admin/phanloaithuoc/addplt', data, (ev) => {
                if (ev == true) {
                    toastr.success('Thêm thành công', 'Thông báo')
                    getlist();
                }
            })
        }
        else {
            var data = $('#formupdate').serialize();
            $.post('/admin/phanloaithuoc/update', data, (ev) => {
                if (ev == true) {
                    toastr.success('Sửa thành công', 'Thông báo')
                    getlist();
                }
            })
        }
    });
    $(document).on('click', '.js-delete', (ev) => {
        var id = ev.target.getAttribute('data-id');
        var check = confirm("bạn có muốn xóa dữ liệu này??")
        if (check == true) {
        $.get('/admin/phanloaithuoc/delete/' + id, (ev)=>{
            if (ev == true) {
                toastr.success('Xóa thành công', 'Thông báo')
                getlist();
            }
        })
        }
        
    })
})
function getlist() {
    $.get('/admin/phanloaithuoc/lisdata', (ev) => {
        var body = document.querySelector("#tbody");
        body.innerHTML = "";
        body.innerHTML = ev;
    })
}