import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hero-test',
  templateUrl: './hero-test.component.html',
  styleUrls: ['./hero-test.component.css']
})
export class HeroTestComponent implements OnInit{

  contagem = 0;

  constructor() {}

  ngOnInit(): void {
  }

  aumentar(): void {
    this.contagem += 1
  }

  diminuir(): void {
    this.contagem -= 1
  }

}
