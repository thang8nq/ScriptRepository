var vueInstance = new Vue({
    el: '#app',
    data: {
        numProductInCart: 0,
        productDisplay: "red.jpg",
        productColor: "Màu đỏ",
        imagePath: "images/",
        currentItemSelectedIndex: 1,
        listProduct: [
            {url: "black.jpg", color: "Màu đen",  quantity: 3, price: "13000", saleOff: 0.2},
            {url: "blue.jpg",  color: "Màu xanh", quantity: 5, price: "16000", saleOff: 0.3},
            {url: "red.jpg",   color: "Màu đỏ",   quantity: 2, price: "22000", saleOff: 0.1}
        ]
    },
    methods: {
        formatPrice(number) {
            return new Intl.NumberFormat('de-DE', { style: 'currency', 
            currency: 'VND' }).format(number); 
        },
        formatPercent(number)
        {
            return new Intl.NumberFormat('de-DE', { style: 'percentage', 
            currency: '%'}).format(number);
        },
       updateProductDisplay(index) {
            this.currentItemSelectedIndex = index;
       }, 
       updateNumberProduct(index)
       {
           if(this.currentItemSelected.quantity > 0) {
               this.numProductInCart++; 
               this.currentItemSelected.quantity -= 1; 
           } else 
           {
               alert("Sản phẩm hết hàng. Chọn sp khác");
           }
       }
    },
    computed: {
       currentItemSelected() {
           return this.listProduct[this.currentItemSelectedIndex];
       }, 
       finalPriceComputed() {
        return this.formatPrice(this.currentItemSelected.price - this.currentItemSelected.saleOff * this.currentItemSelected.price);
       }, 
       originalPriceComputed() {
        return this.formatPrice(this.currentItemSelected.price);
       }, 
       saleOffComputed() {
        return this.currentItemSelected.saleOff * 100;
       }
    }
});
