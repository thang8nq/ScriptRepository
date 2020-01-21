var vueInstance = new Vue({
    el: '#app',
    data: {
        title: 'Google MAP',
        url: 'https://www.google.com/maps',
        target: '_blank',
        number: 4,
        message: 'Thang Nguyen',
        id: 8
    }, 
    methods: {
        say: function(text) {
            return 'Hello ' + text; 
        }
    }
});

console.log(vueInstance);