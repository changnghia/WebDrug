$(document).ready(() => {
    $(document).on("click", ".js-dangki", (ev) => {
        ev.preventDefault();
        var username = document.querySelector(".username").value;
        var password = document.querySelector(".password").value;
        var cfpassword = document.querySelector(".comfirmpassword").value;
        var name = document.querySelector(".name").value;
        var isAdmin = false
        var data = {
            userName: username,
            passWord: password,
            confirmPassword: cfpassword,
            isAdmin: isAdmin,
            hoTen: name
        }
        $.post("/admin/user/signup", data, (data) => {
            if (data == true) {
                Swal.fire(
                    'Đăng ký thành công',
                    'Ấn ok tiếp tục!',
                    'success'
                ).then(() => {
                    window.location.href = "/home/index"
                })
            }
        })
    })
})