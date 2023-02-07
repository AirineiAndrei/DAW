import { Component, OnInit } from '@angular/core';
import { RecipeService } from '../../../core/services/recipe.service';
import { Recipe } from '../../../data/interfaces/recipe';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit {
  public recipes: Array<Recipe> = [];

  constructor(private readonly recipeService: RecipeService) { }

  ngOnInit(): void {
    this.recipeService.getAllRecipes().subscribe((data: Array<Recipe>) => this.recipes = data);
  }

  deleteRecipe(recipeId: string) {
    this.recipeService.deleteRecipe(recipeId).subscribe((data: any) => this.recipes = data);
  }

}
