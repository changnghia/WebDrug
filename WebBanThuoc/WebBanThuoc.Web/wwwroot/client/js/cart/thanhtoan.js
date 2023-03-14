$(document).ready((ev) => {
	getcart();
	$(document).on("click", (".dathang"), (ev) => {
		ev.preventDefault();
		var name = document.querySelector(".name").value
		var diachi = document.querySelector(".diachi").value
		var sdt = document.querySelector(".sdt").value
		var model = {
			TenKH: name,
			DiaChi: diachi,
			SDT: sdt
		}
		$.post("/donhang/dathang", model, (ev) => {
			if (ev == true) {
				Swal.fire(
					'Đặt hàng thành công',
					'Ấn ok tiếp tục!',
					'success'
				).then(() => {
					window.location.href = "/home/index"
				})
			}
		})
	})
})
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
				const tbody = document.querySelector("#total-listcart");
				tbody.innerHTML = "";
				const loadprd = document.querySelector("#load-products");
				for (var i = 0; i < data.length; i++) {
					const { giaTien, tenThuoc, duongdan, id } = data[i];
					
					var html = `<div class="d-flex justify-content-between">
													<p class="mb-2">${tenThuoc}</p>
													<p class="mb-2">${giaTien.toLocaleString("de-DE")} VNĐ</p>
								</div>`;
					tbody.insertAdjacentHTML('beforeend', html);
					loadprd.insertAdjacentHTML("beforeend", html);
				}
				
			}
		});
	}

}