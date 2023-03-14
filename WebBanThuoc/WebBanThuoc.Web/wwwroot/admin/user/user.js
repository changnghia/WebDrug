$(document).ready(() => {
    $(document).on('click', '.dangky', (ev) => {
        ev.preventDefault();
        let signup = false;
        var username = document.querySelector(".username").value;
        $.get('/admin/user/checkuser', { username }, (res) => {
            if (res == true) {
                var mes = document.querySelector('.messageusername')
                mes.innerHTML = "Tài khoản đã tồn tại";
                signup = false;
            }
            else {
                signup=true
            }
        })
        var password = document.querySelector('.password').value;
        var comfirmpassword = document.querySelector('.comfirmpassword').value;
        if (password != comfirmpassword) {
            var mescf = document.querySelector('.messcfpw');
            mescf.innerHTML = "Mật khẩu không trùng khớp"
            signup = false;
        }
        else {
            signup = true
        }
        if (signup) {
            var data = $("#signup").serialize();
            $.post('/admin/user/signup', data, (res) => {
                if (res) {
                    alert("tạo tài khoản thành công")
                    location.href="/admin/user/login"
                }
            })
        }
    });
    $('.password').change((ev) => {
        var input = ev.target;
        if (input.value.length < 5) {
            var mespw = document.querySelector('.mespw');
            mespw.innerHTML = "Mật khẩu quá ngắn"
        }
        else {
            var mespw = document.querySelector('.mespw');
            mespw.innerHTML = ""
        }
    })
})
