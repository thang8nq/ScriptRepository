var vueInstance = new Vue({
    el: '#app',
    data: {
        name: '',
        age: 0
    }, 
    methods: {
        handleName(e)
        {
            this.name = e.target.value;
        }
    }
   
});
