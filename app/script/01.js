// esto  para instanciar  Vuejs

const app = new Vue ({
  el: '#app',
  data: {
    titulo: 'Datos Basicos',    
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
    NuevoDatosBasicos:[
      {Nombre:'', Apellido:'', Edad:0, sexo:'',EstadoCivil:'',Telefono:'',correo:''}
    ],
    DatosBasicos_TD:
    [
      {Nombre:'', Apellido:'', Edad:0, sexo:'',EstadoCivil:'',Telefono:'',correo:''}
    ],

    ListaEstadoCivil:[
      {estado:'Soltero'},
      {estado:'Casado'},
      {estado:'Divorciado'},
      {estado:'Otros'}
    ],
    ListaSexo :[
      {sexo:'Masculino'},
      {sexo:'Femenino'},
      {sexo:'Otros'}
    ],
    Seleccion:'',
    total: 0
  },
  methods:{

    agregarDatos(){
      this.DatosBasicos_TD.push({
        Nombre:this.NuevoDatosBasicos.Nombre, 
        Apellido:this.NuevoDatosBasicos.Apellido,
        Edad:this.NuevoDatosBasicos.Edad,
        sexo: this.lsexo,
        EstadoCivil: this.EstadoCivil,
        Telefono:this.NuevoDatosBasicos.Telefono,
        correo:this.NuevoDatosBasicos.correo
    });

    this.NuevoDatosBasicos.Nombre='';
    this.NuevoDatosBasicos.Apellido='';
    this.NuevoDatosBasicos.Edad=0;
    this.NuevoDatosBasicos.Telefono='';
    this.NuevoDatosBasicos.correo ='';
     
    },
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