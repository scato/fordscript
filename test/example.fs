var x = 4;

assert(x === 4, "x equals 4");

function f(x, y) {
	return x * x;
}

assert(f(1, 4) === 1, "f(1, 4) equals 1");
assert(f(2, 6) === 4, "f(2, 6) equals 4");
assert(f(3, 4) === 9, "f(3, 4) equals 9");
assert(f(4, 6) === 16, "f(4, 6) equals 16");

var g = function(x) { return x + 5; };

assert(g(1) === 6, "g(1) equals 6");
assert(g(2) === 7, "g(2) equals 7");

// lambda notation
var h = function(x) x + 5;

assert(h(1) === 6, "h(1) equals 6");
assert(h(2) === 7, "h(2) equals 7");

var y:Number = 6;

assert(y === 6, "y equals 6");

var p = function(x:Number):Number x + 5;

assert(p(1) === 6, "p(1) equals 6");
assert(p(2) === 7, "p(2) equals 7");

var q = function(x:Number):Number {
	return x * x + x + 5;
};

assert(q(1) === 7, "q(1) equals 7");
assert(q(2) === 11, "q(2) equals 11");

class Animal {
	var legs;
	
  function says() {
	  return "...";
	}
}

var myAnimal:Animal = new Animal();

assert(myAnimal.legs === undefined, "myAnimal has undefined legs");
assert(myAnimal.says() === '...', "myAnimal says '...'");

class Mammal extends Animal {
	var legs:Number = 4;
}

var myMammal = new Mammal();

assert(myMammal.legs === 4, "myMammal has 4 legs");
assert(myMammal.says() === '...', "myMammal says '...'");

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

assert(felix.legs === 4, "felix has 4 legs");
assert(felix.says() === 'prrr', "felix says 'prrr'");

augment Mammal {
	function call():String {
		return "hey, " + this.name + "!";
	}
}

assert(felix.call() === 'hey, Felix!', "call returns 'hey, Felix!'");

class Vet {
  static var name = 'Mister Vet';
  
  static function bring(animal:Animal):void {
    animal.legs += 1;
  }
}

assert(Vet.name === 'Mister Vet', "Vet is called Mister Vet");

Vet.bring(felix);

assert(felix.legs === 5, "felix now has 5 legs");
