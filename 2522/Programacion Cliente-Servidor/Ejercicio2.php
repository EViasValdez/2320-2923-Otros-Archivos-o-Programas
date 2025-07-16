<?php
    class AnimalDomestico {
        public $Especie;
        public $Color;
        public $Accion;
        public $Tipo;

        public function Gato() {
            return $this->Especie = "Felino";
            return $this->Color = "Negro claro";
            return $this->Accion = "Maullar";
            return $this->Tipo = "Gris";
        }
        public function Perro() {
            return $this->Especie = "Canino";
            return $this->Color = "Blanco";
            return $this->Accion = "Ladrar";
            return $this->Tipo = "Beagle";
        }
    }
    class Veiculo {
      public $Color;
      public $Marca;
      public $Modelo;

      public function Moto() {
        return $this->Color = "Blanco";
        return $this->Marca = "Italika";
        return $this->Modelo = "2020";
      }
      public function Auto() {
        return $this->Color = "Verde";
        return $this->Marca = "Volkswagen";
        return $this->Modelo ="2021";
      }
    }
    class DispositivoDigital {
      public $Proposito;
      public $Modelo;
      public $Color;
      public $Marca;
      public $Tipo;

      public function Camara() {
        return $this->Proposito = "Fotografia";
        return $this->Modelo = "C80";
        return $this->Color = "Azul";
        return $this->Marca = "Canon";
        return $this->Tipo = "Semiprofesional";
      }
      public function Celular() {
        return $this->Proposito = "Telefonia celular";
        return $this->Modelo = "R12";
        return $this->Color = "Negro";
        return $this->Marca = "Samsung";
        return $this->Tipo = "Una sola camara";
      }
    }
?>