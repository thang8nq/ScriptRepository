var vueInstance = new Vue({
    el: '.app', 
    data: {
        tabSelected: 'login'
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