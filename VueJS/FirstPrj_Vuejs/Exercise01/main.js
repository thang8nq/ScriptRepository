var vueInstance = new Vue({
    el: '#app',
    data: {
        numProductInCart: 0,
        productDisplay: "red.jpg",
        productColor: "Màu đỏ",
        imagePath: "images/",
        listProduct: [
            {url: "black.jpg", color: "Màu đen"},
            {url: "blue.jpg",  color: "Màu xanh"},
            {url: "red.jpg",   color: "Màu đỏ"}
        ]
    },
    methods: {
       updateProductDisplay(item) {
            this.productDisplay = item.url;
            this.productColor = item.color;
       }

    },
    computed: {
       
    }
});
