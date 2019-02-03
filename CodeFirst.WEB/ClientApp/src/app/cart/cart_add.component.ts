import { Component } from '@angular/core';

@Component({
  selector: 'cart_add-component',
  template: `
            <h1>Cart</h1>
            <h3>Current items: {{ this.currentCount }}

            <button type="button" class="btn btn-dark float-right">
              <i class="fas fa-plus-circle"></i>
            </button>
`,
  styles: ['button.add_new_item { border-radius: 50%; }']
})
export class Cart_AddComponent {
  public currentCount = 0;


}
