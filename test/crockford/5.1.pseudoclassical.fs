module {

// 5.1 Pseudoclassical
document.write("<div><strong>5.1 Pseudoclassical</strong></div>");

class Mammal {
    function constructor(name) {
        this.name = name;
    }
    
    function get_name() {
        return this.name;
    }
    
    function says() {
        return this.saying || '';
    }
}

var myMammal = new Mammal('Herb the Mammal');

assert(myMammal.name === 'Herb the Mammal', "myMammal has correct name");
assert(myMammal.get_name() === 'Herb the Mammal', "get_name returns correct name");
assert(myMammal.says() === '', "says returns empty string");

class Cat extends Mammal {
    function constructor(name) {
        super.constructor(name);
        
        this.saying = 'meow';
    }
    
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
}

var myCat = new Cat('Henrietta');

assert(myCat.name === 'Henrietta', "myCat has correct name");
assert(myCat.get_name() === 'Henrietta', "get_name returns new name");
assert(myCat.says() === 'meow', "says returns meow");
assert(myCat.purr(5) === 'r-r-r-r-r', "purr returns the correct number of r's");

}
