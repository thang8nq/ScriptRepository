var vueInstance = new Vue({
    el: '.app', 
    data: {
        users: [
            {name: 'Thang', age: 20, isActive: false},
            {name: 'Hai',   age: 18, isActive: true}, 
            {name: 'Anh',   age: 16, isActive: false},
            {name: 'Quang', age: 15, isActive: true}
        ]
    }, 
    methods: {
       
    }, 
    computed: {
        activedUsers: function() { 
            return this.users.filter(function(u){
                return u.isActive;
            });
        }
    }
});