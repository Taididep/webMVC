function refreshCart() {
    $.ajax({
        url: '/SanPham/GetCartItems',
        type: 'GET',
        success: function (partialView) {
            $('#cartBody').html(partialView);
        }
    });
}



function updateQuantity(productId, change) {
    $.ajax({
        url: '/SanPham/UpdateQuantity',
        type: 'POST',
        data: { productId: productId, change: change },
        success: function (result) {
            // Cập nhật số lượng và tổng tiền trên giao diện
            var quantityElement = $('#quantity_' + productId);
            var totalElement = $('#total_' + productId);

            var newQuantity = parseInt(quantityElement.text()) + change;
            if (newQuantity >= 0) {
                quantityElement.text(newQuantity);
                totalElement.text(result);
            }
            refreshCart();
        }
    });
}

function deleteItem(productId) {
    $.ajax({
        url: '/SanPham/DeleteCartItem',
        type: 'POST',
        data: { productId: productId },
        success: function () {
            refreshCart();
        }
    });
}

function processPayment() {
    var selectedItems = document.querySelectorAll('input[name="selectedItems"]:checked');

    if (selectedItems.length === 0) {
        alert("Vui lòng chọn ít nhất một sản phẩm để thanh toán.");
        return;
    }
    // Lấy danh sách ID sản phẩm được chọn
    var selectedIds = Array.from(selectedItems).map(item => parseInt(item.value));

    // Gửi danh sách ID sản phẩm được chọn đến trang xử lý thanh toán
    $.ajax({
        url: '/SanPham/ProcessPayment',
        type: 'POST',
        data: { selectedIds: selectedIds },
        traditional: true,
        success: function () {
            // Thực hiện xóa sản phẩm khỏi giao diện và làm mới giỏ hàng
            selectedIds.forEach(function (productId) {
                deleteItem(productId);
                refreshCart();
                alert("Bạn đã thanh toán thành công");
            });
        },
    });
}
function GetNews() {
    $.ajax({
        type: 'GET',
        url: '/api/TinTucAPI',
        success: (responses) => {
            for (var i = 0; i < responses.length; i++) {
                const newsRow = responses[i];
                const imgSrc = window.location.origin + '/Imgs/' + newsRow.DUONGDAN;

                const strHTML =
                    '<tr>' +
                    '<td><img src="' + imgSrc + '" class="card-img-top" alt="' + newsRow.TIEUDE + '"></td>' +
                    '<td>' + newsRow.TIEUDE + '</td>' +
                    '<td>' + newsRow.NOIDUNG + '</td>' +
                    '<td>' + newsRow.NGAYDANG + '</td>' +
                    '</tr>';
                $('.newsTable').append(strHTML);
            }
        },
        error: (err) => { console.log(err); }
    });
}


