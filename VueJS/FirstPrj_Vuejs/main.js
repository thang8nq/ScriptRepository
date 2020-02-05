var vueInstance = new Vue({
    el: '#app',
    data: {
    }, 
    methods: {
        callFunction ()
        {
            console.log("We calling a function");
        }
    }, 
    computed: {
        callComputed()
        {
            console.log("We calling a computed");
        }
    }
});

console.log(vueInstance);