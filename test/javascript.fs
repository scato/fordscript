//final
class Object {
  // native
  function toString():String {}
  function valueOf():Object {}
}

//final
class Number extends Object {
  static var MAX_VALUE:Number;
  static var MIN_VALUE:Number;
  static var NaN:Number;
  static var NEGATIVE_INFINITIY:Number;
  // HOEFT NIET: static var prototype:Number;
  
  function toExponential():String {}
  function toFixed():String {}
}

//final
class String extends Object {
  function toLowerCase():String {}
  function toUpperCase():String {}
}

class Array extends Object {
  function concat(a, b):Array {}
}

class Arguments {
}

class Function extends Object {
  function apply(object:Object, arguments:Arguments):Object {}
}
