<?php
    class Animal {
        public $Nombre = "Gato ";
        public $Especie = "Felino ";
        public $Tipo = "Domestico ";
        public $Color = "Gris ";
        public $Alimentacion = "Variada ";
        
        function Retornar() {
            return $this->Nombre;
            return $this->Especie;
            return $this->Tipo;
            return $this->Color;
            return $this->Alimentacion;
        }
        
        function Imprimir() {
            for ($a = 0; $a < 100; $a++)
            {
                echo $this->Nombre;
                echo $this->Especie;
                echo $this->Tipo;
                echo $this->Color;
                echo $this->Alimentacion;
            }
        }
    }
    
    $animalc = new Animal();
    $animalc->Imprimir();
?>