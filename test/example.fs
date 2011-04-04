var x = 4;

function f(x) {
	return x * x;
}

var g = function(x) { return x + 5; };

// lambda notation
var h = function(x) x + 5;

var y:Number = 6;

var p = function(x:Number):Number x + 5;

var q = function(x:Number):Number {
	return x * x + x + 5;
};

class Animal {
	var legs = undefined;
	
  function says() {
	  return "...";
	}
}

class Mammal extends Animal {
	var legs = 4;
}

class Cat extends Mammal {
	var name:String;
	
	function constructor(name) {
		this.name = name;
	}
	
	function says() {
		return "prrr";
	}
}
var felix:Cat = new Cat("Felix");

felix.says();

augment Mammal {
	function call() {
		return "hey, " + this.name + "!";
	}
}

felix.name.;
