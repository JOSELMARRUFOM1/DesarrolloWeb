/// SCRUD  CLientes (Agregar, actualizar, eliminar)
var vm = new Vue({
  el: '#app1',
  data: {
    message: '123',
    InfoPersonas:[
      {Nombre:'Jose',Edad:45,Cargo:'Developer'},
      {Nombre:'Daniel',Edad:43,Cargo:'Developer1'},
      {Nombre:'David',Edad:34,Cargo:'Lider'}
 ],
  }

})
vm.message = 'new message' // change data
vm.$el.textContent === 'new message' // false
Vue.nextTick(function () {
  vm.$el.textContent === 'new message' // true
})