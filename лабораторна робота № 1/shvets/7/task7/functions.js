const Port = require('./Port.js')
const Ship = require('./Ship.js')
const Pier = require('./Pier.js')
const ShipOnPier = require('./ShipOnPier.js')

//-------------------ПОРТ------------------
//----------СТВОРЕННЯ МАСИВУ ПОРТІВ------------
function createListOfPorts (i) {
  const ports = [new Port({ id: 0, name: 'Port number 0' })]
  for (let j = 1; j < i; j++) {
    ports.push(new Port({ id: j, name: 'Port number ' + j.toString() }))
  }
  return ports
}

let ports = createListOfPorts(20)
console.log(ports)


//----------ДОДАВАННЯ ПОРТУ У КОЛЕКЦІЮ------------
function addNewPort (name, portsList) {
  portsList.push(new Port({ id: portsList.length, name: name }))
}

//addNewPort('Monako', ports)
//console.log(ports)


//----------РЕДАГУВАННЯ ПОРТУ------------
function refactorPort (id, newName, portsList) {
  portsList.map(Port => {
    if (Port.id === id) {
      Port.name = newName
    }
  })
}

//refactorPort(4, 'Venice', ports)
//console.log(ports)

//----------ВИДАЛЕННЯ ПОРТУ З КОЛЕКЦІЇ------------
function deletePort (id, portList) {
  return portList = portList.filter(Port => Port.id !== id)
}

//ports = deletePort(12, ports)
//console.log(ports)

//----------ПОШУК ПОРТУ В КОЛЕКЦІЇ------------
function findPortById (id, portsList) {
  return portsList.filter(pas => pas.id === id)
}

//console.log(findPortById(4, ports));


//-------------------ПРИСТАНЬ------------------

//---------------СТВОРЕННЯ ПРИСТАНІ------------
function createListOfPiers (i) {
  const Piers = [new Pier({ id: 0, name: 'pier number 0', Port: 0 })]
  for (let j = 1; j < i; j++) {
    Piers.push(new Pier({ id: j, name: 'pier number '+ j, Port: j}))
  }
  return Piers
}
Piers = createListOfPiers(10)
//console.log(Piers);

//---------------ДОДАВАННЯ ПРИСТАНІ----------------
function addNewPier (id,Name, Port, PiersList) {
  PiersList.push(new Pier({ id: id, name: Name, Port: Port }))
}

addNewPier(1,'aditionalPier', 1, Piers)
//console.log(Piers);

//---------------ВИДАЛЕННЯ ПРИСТАНІ----------------
function deletePier (id, PiersList) {
  return PiersList = PiersList.filter(Pier => Pier.id !== id)
}
//Piers = deletePier(0, Piers)
//console.log(Piers);

// function findPierById (id, PiersList) {
//   return PiersList.filter(Pier => Pier.id === id)
// }
//console.log(findPortById(4, Piers));

//--------------------КОРАБЕЛЬ------------------

//---------------СТВОРЕННЯ КОЛЕКЦІЇ КОРАБЛІВ--------------
var Ships = [new Ship({ id: 0, model: 'model 0', on_pier: false }),
  new Ship({ id: 1, model: 'model 1', on_pier: false }),
  new Ship({ id: 2, model: 'model 2', on_pier: false }),
  new Ship({ id: 3, model: 'model 3', on_pier: false }),
  new Ship({ id: 4, model: 'model 4', on_pier: false }),
  new Ship({ id: 5, model: 'model 5', on_pier: false })
]
//console.log(Ships)
//--------------ДОДАВАННЯ КОРАБЛЯ В КОЛЕКЦІЮ--------------
function addNewShip (Model, shipsList) {
  shipsList.push(new Ship({ id: shipsList.length, model: Model, on_pier: false}))
}

addNewShip('STAR', Ships)
//console.log(Ships)

//----------------РЕДАГУВАННЯ КОРАБЛЯ--------------------

function changeShip (Ship, newModel) {
  for (i = 0; i < Ships.length; i++) {
    if(Ships[i] == Ship)
      Ships[i].model = newModel
  }
}
changeShip(Ships[3], 'LuckyOne')
//console.log(Ships);

//--------------ВИДАЛЕННЯ КОРАБЛЯ З КОЛЕКЦІЇ-------------

function deleteShip (id, ShipsList) {
  return ShipsList = ShipsList.filter(Ship => Ship.id !== id)
}

// Ships = deleteShip(0, Ships)
// console.log(Ships);

//-----------------ПОШУК КОРАБЛЯ ПО АЙДІ------------------

function findShipById (id, shipsList) {
  return shipsList.filter(Ship => Ship.id === id)
}
//console.log(findShipById(4, Ships));

//---------СТВОРЕННЯ КОЛЕКЦІЇ КОРАБЛІВ НА ПРИСТАНІ--------
var ShipsOnPier = [new ShipOnPier({ Pier: Piers[1], Ship: Ships[6] })]
//console.log(ShipsOnPier)

//----------------ПРИБУТТЯ/ВІДБУТТЯ КОРАБЛЯ---------------

//------------ДОДАВАННЯ КОРАБЛЯ НА ПРИСТАНІ---------------
// те саме що і прибуття
function addNewShipOnPier (Pier,Ship,ShipsOnPierList) {
  ShipsOnPierList.push(new ShipOnPier({Pier: Pier, Ship:Ship }))
}

addNewShipOnPier(Piers[2], Ships[3],ShipsOnPier)
addNewShipOnPier(Piers[1], Ships[4],ShipsOnPier)
addNewShipOnPier(Piers[1], Ships[2],ShipsOnPier)
addNewShipOnPier(Piers[1], Ships[1],ShipsOnPier)

//console.log(ShipsOnPier)

//-------------ВИДАЛЕННЯ КОРАБЛЯ НА ПРИСТАНІ--------------
//відбуття корабля з пристані
function deleteShipOnPier (Ship, ShipsList) {
  return ShipsList = ShipsList.filter(ShipOnPier => ShipOnPier.Ship !== Ship)
}

ShipsOnPier = deleteShipOnPier(Ships[1],ShipsOnPier)
//console.log(ShipsOnPier);
//-------------ПОШУК ВСІХ КОРАБЛІВ НА ПРИСТАНІ-------------
function findShipByPier (Pier, shipsList) {
  return shipsList.filter(ShipOnPier => ShipOnPier.Pier === Pier)
}
//console.log(findShipByPier(Piers[1], ShipsOnPier));