module {

// 5.4 Functional
document.write("<div><strong>5.4 Functional</strong></div>");

static class mammal {
	protected var name;
	protected var saying;
	
    public function get_name() {
        return this.name;
    }
	
    public function says() {
        return this.saying || '';
    }
}

var myMammal = mammal({name: 'Herb the Mammal'});

assert(myMammal.name === undefined, "name is not readable");
assert(myMammal.get_name() === 'Herb the Mammal', "get_name returns correct name");
assert(myMammal.says() === '', "says returns empty string");

static class cat extends mammal {
    protected var saying = 'meow';
    
    public function purr(n) {
        var i, s = '';
        for (i = 0; i < n; i += 1) {
            if (s) {
                s += '-';
            }
            s += 'r';
        }
        return s;
    }
    
    public function get_name() {
        return this.says() + ' ' + this.name + ' ' + this.says();
    }
}

var myCat = cat({name: 'Henrietta'});

assert(myCat.name === undefined, "name is unreadable");
assert(myCat.get_name() === 'meow Henrietta meow', "get_name returns correct string");
assert(myCat.says() === 'meow', "says returns meow");
assert(myCat.purr(5) === 'r-r-r-r-r', "purr returns the correct number of r's");

static class coolcat extends cat {
	public function get_name() {
		return 'like ' + super.get_name() + ' baby';
    }
}

var myCoolCat = coolcat({name: 'Bix'});
var name = myCoolCat.get_name();
//        'like meow Bix meow baby'

assert(myCoolCat.get_name() === 'like meow Bix meow baby', "get_name returns correct string");

var newCat = new cat({name: 'None'});

assert(newCat.name === undefined, "new keyword circumvents conversion");

static class namedcat extends cat {
  public function constructor(name) {
    this.name = name;
  }
}

var felix = new cat("Felix");

assert(felix.name === undefined, "name is not accessable");
assert(felix.get_name() === 'meow Felix meow', "get_name returns correct string");

}
