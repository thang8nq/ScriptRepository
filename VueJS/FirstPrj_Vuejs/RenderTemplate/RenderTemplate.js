var vueInstance = new Vue({
    el: '.app', 
    data: {
        tabSelected: 'login', 
        users: [
            {name: 'Thang', age: 20},
            {name: 'Hai', age: 18}, 
            {name: 'Anh', age: 16}
        ]
    }, 
    methods: {
        changeTab(tab)
        {
            this.tabSelected = tab;
        }
    }, 
    computed: {
        
    }
});