(function(){

    var list = document.querySelector('#list'),
        form = document.querySelector('form'),
        item = document.querySelector('#item');

    form.addEventListener('submit',function(e){
        e.preventDefault();
        list.innerHTML += '<li>' + item.value + '</li>';
        store();
        item.value = "";
    },false)

    list.addEventListener('click',function(e){
        var tar = e.target;
        if(tar.classList.contains('checked')){
            tar.parentNode.removeChild(tar);
        } else {
            tar.classList.add('checked');
        }
        store();
    },false)

    function store() {
        window.localStorage.myitems = list.innerHTML;
    }

    function getValues() {
        var storedValues = window.localStorage.myitems;
        if(!storedValues) {
            list.innerHTML = '<li>Make a to do list</li>'+
                '<li>Click on list item if done</li>'+
                '<li>Click on list item two times if delete</li>';
        }
        else {
            list.innerHTML = storedValues;
        }
    }
    getValues();
})();