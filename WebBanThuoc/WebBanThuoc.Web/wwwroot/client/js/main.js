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

const btn = document.querySelectorAll(".btn-add") //lấy tất cả các class btn-add
//console.log(btn);
btn.forEach(function(button,index){
    button.addEventListener("click",function(event){
        var btnitem=event.target //lấy phần tử của chính btn vừa click
        console.log(btnitem)
        var product=btnitem.parentElement //lấy phẩn tử từ class cha
        var productIMG=product.querySelector("img").src //lấy 1 các class btn-add
        var productName=product.querySelector("H2").innerText
        var productPrice=product.querySelector("span").innerText
        addcart(productPrice,productName,productIMG)
        deleteCart()
        inputchange()
    });
})
function addcart(productPrice,productName,productIMG){
    var addtr=document.createElement("tr")
    // kiểm tra xem sản phẩm vừa thêm có trong giỏ hàng hay chưa
    var cartitem=document.querySelectorAll("tbody tr")
    for(var i=0;i<cartitem.length;i++)
    {
        var product=document.querySelectorAll(".title")
        if(product[i].innerHTML==productName){
         alert("Sản phẩm của bạn đã có trong giỏ hàng");
            return
        }
    }
    addtr.innerHTML=` 
    <td style="display: flex; align-items: center;"><img style="width:70px" src="${productIMG}" alt=""><span class="title">${productName}</span></td>
    <td> <p><span class="abc">${productPrice}</span><sup>đ</sup></p></td>
    <td><input class="input" style="width:30px;outline:none;" type="number" value="1" min="1"></td>
    <td class="delete" style="cursor: pointer;">Xóa</td>`
    var carttable=document.querySelector("tbody")
    carttable.append(addtr)
    carttotal()
}
// --------------------- Tính tổng tiền hàng------------------
function carttotal(){
    var cartitem=document.querySelectorAll("tbody tr")
    var tong=0;
    for(var item=0;item< cartitem.length;item++){
        var inputvalue= cartitem[item].querySelector("input").value
        // console.log(inputvalue);
        var spanvalue=cartitem[item].querySelector(".abc").innerText
        // console.log(spanvalue)
        var totalA =inputvalue*spanvalue*1000 
        tong=tong+totalA
        // var totalB=tong.toLocaleString('de-DE')
    } 
    var cartotal=document.querySelector(".price-total span")
    var cartIcon=document.querySelector(".cart-icon span")
    cartotal.innerText=tong.toLocaleString('de-DE')
    cartIcon.innerHTML=tong.toLocaleString('de-DE')
}
//============================xóa==========================
function deleteCart(){
    var cartitem=document.querySelectorAll("tbody tr")
    for(var i=0;i<cartitem.length;i++)
    {
        var product=document.querySelectorAll(".delete")
        product[i].addEventListener("click",function(ev){
            var cartDelete=ev.target
            var cartItem=cartDelete.parentElement
            cartItem.remove()
            carttotal()
        })  
    }
}

function inputchange(){
    var cartitem=document.querySelectorAll("tbody tr")
    for(var i=0;i<cartitem.length;i++)
    {
         var input=cartitem[i].querySelector(".input")
        input.addEventListener("change",function(ev){
            carttotal()
        })
    }
}
// ==================nav bar========
const cartbtn = document.querySelector(".fa-times")
const cartShow = document.querySelector(".cart")
cartShow.addEventListener("click",function(){
    document.querySelector(".showcart").style.right="0"
})
cartbtn.addEventListener("click",function(){
    document.querySelector(".showcart").style.right="-100%"
})