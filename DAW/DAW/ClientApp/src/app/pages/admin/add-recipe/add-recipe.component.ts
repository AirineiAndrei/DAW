import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { RecipeService } from '../../../core/services/recipe.service';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {
  public recipeForm = this.formBuilder.group({
    title: ['', Validators.required],
    instructions: ['', Validators.required],
    cooktime: ['', Validators.required],
    totaltime: ['', Validators.required],
  });

  constructor(private readonly formBuilder: FormBuilder, private readonly RecipeService: RecipeService) { }

  ngOnInit(): void {
  }

  checkForm() {
    if (this.getFormValidationError(['title', 'instructions'])) {
      console.log("Ai apasat butonul de submit");
      this.RecipeService.addNewRecipe(this.recipeForm.value).subscribe(data => console.log(data))
    }
  }

  getFormValidationError(keys: any) {
    var ans = true
    keys.forEach((key: any) => {
      const controlErrors = this.recipeForm.get(key)?.errors;
      if (controlErrors != null) {
        console.error(key + ' has errors: ' + controlErrors);
        ans = false;
      }
        console.log(key + "ok");
    });
    return ans;
  }
  
}
