var vueInstance = new Vue({
    el: '#app',
    data: {
        title: 'Dien thoai Samsung'
    }, 
    methods: {
        say: function(text) {
            return 'Hello ' + text; 
        }
    }
});

//He thong phan ung (Reactivity)
setTimeout(() => {
    vueInstance.title = 'Dien thoai Oppo';
}, 3000);
console.log(vueInstance);