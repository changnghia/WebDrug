

$(document).ready(() => {
    $(document).on("click", ".js-timkiem", (ev) => {
        ev.preventDefault();
        var search = document.querySelector(".search").value;
        $.get("/home/list", { seachThuoc: search }, (data) => {
            var body = document.querySelector("#list")
            body.innerHTML=data
        })
    })
})
//function getlist() {
//    $.get('/home/listdata', (ev) => {
//        var bodylist = document.querySelector("#list");
//		bodylist.innerHTML = "";
//        var currentPage = 1;
//        var pageSize = 5;
//        var totalRow = ev.length;
//        console.log(totalRow)
//		ev.forEach((data) => {
           
//			const { id, giaTien, tenThuoc, congDung, duongdan } = data;			
//				var html = `
//                <div class="col-md-4 col-sm-6" >
//					<div class="team-thumb wow fadeInUp" data-wow-delay="0.2s">
//					<img src="/img/${duongdan}" class="img-responsive" alt="">

//					<div class="team-info">
//						<h3>${tenThuoc}</h3>
//						<p>${congDung}</p>
//						<div class="team-contact-info">
//							<p><i class="fa fa-phone"></i> 010-020-0120</p>
//							<p><i class="fa fa-envelope-o"></i> <a href="#">${giaTien}</a></p>
//						</div>
//						<ul class="social-icon">
//							<li><a href="#" class="fa fa-cart-arrow-down add-cart" data-id=${id}></a></li>
//							<li><a href="#" class="fa fa-search"></a></li>
//						</ul>
//					</div>

//				</div>
//				</div>
//                `
				
//				bodylist.insertAdjacentHTML('afterend', html)
//        })
//        var arrPager = getPager(currentPage, pageSize, totalRow);
//        console.log(arrPager)
//    })
//}
function getPager(currentPage, pageSize, totalRow) {
    const ON_EACH_SIDE = 4;
    var arrPager = [];
    var totalPage = Math.ceil(totalRow / pageSize);

    currentPage = parseInt(currentPage);
    if (totalPage == 0) {
        return arrPager;
    } else {
        // current page
        arrPager.push({
            isCurrentPage: true,
            text: currentPage,
            page: currentPage,
        });
        // after current page
        var i = 1;
        while (currentPage + i <= totalPage) {
            arrPager.push({
                isCurrentPage: false,
                text: currentPage + i,
                page: currentPage + i,
            });
            i++;
            if (i > ON_EACH_SIDE) break;
        }
        if (currentPage + ON_EACH_SIDE < totalPage) {
            arrPager.push({
                isCurrentPage: false,
                text: "&rArr;",
                page: totalPage,
            });
        }

        // before current page
        i = 1;
        var tmp = currentPage;
        while (tmp > 1) {
            arrPager.unshift({
                isCurrentPage: false,
                text: currentPage - i,
                page: currentPage - i,
            });
            i++;
            tmp--;
            if (i > ON_EACH_SIDE) break;
        }
        if (currentPage - ON_EACH_SIDE > 1) {
            arrPager.unshift({
                isCurrentPage: false,
                text: "&lArr;",
                page: 1,
            });
        }
    }
    return arrPager;
}
