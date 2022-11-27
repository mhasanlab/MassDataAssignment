import { Component } from '@angular/core';
import {faHome, faBowlFood} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MassFood';
  faHome = faHome
  faBowlFood = faBowlFood
}
