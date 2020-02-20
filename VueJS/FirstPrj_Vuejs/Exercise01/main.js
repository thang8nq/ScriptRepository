var vueInstance = new Vue({
    el: '#app',
    data: {
        numProductInCart: 0,
        productDisplay: "red.jpg",
        productColor: "Màu đỏ",
        imagePath: "images/",
        currentItem: null,
        listProduct: [
            {url: "black.jpg", color: "Màu đen",  quantity: 3},
            {url: "blue.jpg",  color: "Màu xanh", quantity: 5},
            {url: "red.jpg",   color: "Màu đỏ",   quantity: 2}
        ]
    },
    methods: {
       updateProductDisplay(item) {
            this.productDisplay = item.url;
            this.productColor = item.color;
            this.currentItem = item;
       }, 
       updateNumberProduct(currentItem)
       {
           if(this.currentItem.quantity > 0)
           {
               this.numProductInCart++;
               this.currentItem.quantity -= 1; 
           }
       }

    },
    computed: {
       
    }
});
