$(document).ready((ev) => {
    $(document).on('click', '.add-cart', (ev) => {
        ev.preventDefault();
        var id = ev.target.getAttribute("data-id");
		setCookie("products_" + id, 1, 200)
		getcart();
	})
	$(document).on('click', '.delete-cookies', (ev) => {
		var id = ev.target.getAttribute("data-id");
		setCookie("products_" + id, 1, -1);
		getcart();
	})
	$(document).on("click", ".tang", (ev) => {
		var btn = ev.target
		var id = btn.getAttribute("data-id");
		var soluong = parseInt(getCookie("products_" + id)) + 1
		setCookie("products_" + id, soluong, 200)
		var td = btn.parentElement
		var input = td.querySelector("input");
		input.value = soluong;
		totalprice();
	})

	$(document).on("click", ".giam", (ev) => {
		var btn = ev.target
		var id = btn.getAttribute("data-id");
		var soluong = parseInt(getCookie("products_" + id)) - 1
		setCookie("products_" + id, soluong, 200)
		var td = btn.parentElement
		var input = td.querySelector("input");
		input.value = soluong;
		totalprice();
	})
	getcart();
	
});

const split = () => {
    var cookieString = document.cookie.split(';');

    var intArr = [];

    for (var i = 0; i < cookieString.length; i++) {

        if (cookieString[i].indexOf("products_") > -1) {
            var temp = cookieString[i].replace("products_", "")
            var interger = temp.split("=")[0];
            intArr.push(interger);
        }
    }
}
function setCookie(cname, cvalue, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}
function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}
function getcart() {
	const allCookie = document.cookie;
	const cookieArray = allCookie.split(';');
	var newArrayCookie = [];
	for (var i = 0; i < cookieArray.length; i++) {
		if (cookieArray[i].indexOf("products_") != -1) {
			newArrayCookie.push(parseInt(cookieArray[i].replace("products_", "").split("=")[0].trim()));
		}
	};
	if (newArrayCookie.length == 0) {
		const tbody = document.querySelector("#cart-body");
		tbody.innerHTML = "";
		tbody.innerHTML = `
			<h1>Không có sản phẩm trong giỏ hàng</h1>
		`
	}
	else {
		$.post('/home/cart', { idList: newArrayCookie }, function (data, a, b) {
			if (data.length > 0) {
				const tbody = document.querySelector("#cart-body");
				tbody.innerHTML = "";
				console.log(data);
				for (var i = 0; i < data.length; i++) {
					const { giaTien, tenThuoc, duongdan, id } = data[i];
					var html = `<tr>
						<td style="display: flex; align-items: center;">
							<img style="width:70px" src="/img/${duongdan}" alt="">
							<div style="width: 85px; height: 30px;overflow: hidden"; text-overflow: ellipsis >
								<p  class="menu-cart ml-1">${tenThuoc}</p>
							</div>
							<br>
							<p style="margin-top: 46px;margin-left: -86px;"><span class="abc">${giaTien.toLocaleString("de-DE")}</span><span>VNĐ</span></p>
						</td>						
						<td>							
									<button style="border-width:0.65px;border-color:black;border-style: solid;margin-top: -3px" data-id="${id}" class="giam btn-minus btn btn-default" type="button">–</button>
									<input class="input" style="width:30px;outline:none;align-items: center;" type="text" class="input-text number-sidebar gia" value="${getCookie("products_" + id)}" min="1">
									<button style="border-width:0.65px;border-color:black;border-style: solid;margin-top: -3px" data-id="${id}" class="tang btn-plus btn btn-default" type="button">+</button>							
						</td>
						<td data-id="${id}" class="delete-cookies" style="cursor: pointer;">Xóa</td>
					</tr>`;
					tbody.insertAdjacentHTML('beforeend', html);
				}
				totalprice();
			}
		});
	}
	
}
function totalprice() {
	var price = document.querySelectorAll("tbody tr")
	var tong = 0;
	if (price.length != 0) {
		for (var i = 0; i < price.length; i++) {
			var gia = price[i].querySelector(".abc").innerHTML;
			var soluong = price[i].querySelector("input").value;
			tong = tong + (gia * soluong)
			
		}
	}
	else {
		tong = 0;
	}
	var total = document.querySelector(".price-total span")
	var demp = document.querySelector(".navbar-nav sup")
	total.innerHTML = tong.toLocaleString("de-DE");
}