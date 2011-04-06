// 5.4 Functional

constructor mammal {
	protected var name;
	protected var saying;
	
    public function get_name() {
        return this.name;
    }
	
    public function says() {
        return this.saying || '';
    }
};

var myMammal = mammal({name: 'Herb'});

constructor cat extends mammal {
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

constructor coolcat {
	public function get_name() {
		return 'like ' + super.get_name() + ' baby';
    }
}

var myCoolCat = coolcat({name: 'Bix'});
var name = myCoolCat.get_name();
//        'like meow Bix meow baby'

