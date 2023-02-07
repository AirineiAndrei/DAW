import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'

@Component({
  selector: 'app-ingredient',
  templateUrl: './ingredient.component.html',
  styleUrls: ['./ingredient.component.css']
})
export class IngredientComponent implements OnInit {

  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
      var id_ruta = this.route.snapshot.paramMap.get('id');
      console.log("a primit id-ul " + id_ruta + "ca parametru");
  }

}
