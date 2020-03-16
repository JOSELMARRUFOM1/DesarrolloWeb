// esto  para instanciar  Vuejs

const app = new Vue ({
  el: '#app',
  data: {
    titulo: 'Hola Mundo con vue',    
    Actividades1: [
        {tarea:'Desarrollo'},
        {tarea:'Pruebas'},
        {tarea:'Despliegue'}
    ],
    InfoPersonas:[
         {Nombre:'Jose',Edad:45,Cargo:'Developer'},
         {Nombre:'Daniel',Edad:43,Cargo:'Developer1'},
         {Nombre:'David',Edad:34,Cargo:'Lider'}
    ],
    NuevaActividad:'',
    NuevoEmpleado:[
      {Nombre:'',Edad:0,Cargo:''}
    ],
    total: 0
  },
  methods:{

     agregarPersona () {
       
       this.InfoPersonas.push({
           Nombre:this.NuevoEmpleado.Nombre, Edad:this.NuevoEmpleado.number.Edad, Cargo:this.NuevoEmpleado.Cargo
       })
     },
     agregarActividad(){
        this.Actividades1.push({
            tarea:this.NuevaActividad
        });
        this.NuevaActividad='';
     }

  },
  computed:{
 
    sumarEdad(){


    }


  }

})