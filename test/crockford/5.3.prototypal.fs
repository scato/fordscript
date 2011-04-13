module {

// 5.3 Prototypal
document.write("<div><strong>5.3 Prototypal</strong></div>");

prototype myMammal {
    var name = 'Herb the Mammal';
    
    function get_name() {
        return this.name;
    }
    
    function says() {
         return this.saying || '';
    }
}

assert(myMammal.name === 'Herb the Mammal', "myMammal has correct name");
assert(myMammal.get_name() === 'Herb the Mammal', "get_name returns correct name");
assert(myMammal.says() === '', "says returns empty string");

prototype myCat extends myMammal {
    var name = 'Henrietta';
    var saying = 'meow';
    
    function purr(n) {
        var i, s = '';
        for(i = 0; i < n; i += 1) {
            if(s) {
                s += '-';
            }
            s += 'r';
        }
        return s;
    }
    
    function get_name() {
        return this.says() + ' ' + this.name + ' ' + this.says();
    }
}

assert(myCat.name === 'Henrietta', "myCat has correct name");
assert(myCat.get_name() === 'meow Henrietta meow', "get_name returns name with meow around it");
assert(myCat.says() === 'meow', "says returns meow");
assert(myCat.purr(5) === 'r-r-r-r-r', "purr returns the correct number of r's");

}
