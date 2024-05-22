import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-bookicon',
  standalone: true,
  imports: [],
  templateUrl: './bookicon.component.html',
  styleUrl: './bookicon.component.css'
})
export class BookiconComponent {
  @Input() title!: string;
  @Input() author!: string;
  @Input() description!: string;
  @Input() genre!: string;
  @Input() img!: string;


  constructor(private router: Router){
  }

  bookNavigate(){
    this.router.navigate(['/book-page'], 
      {queryParams: {title: this.title, 
        author: this.author, 
        description: this.description, 
        genre: this.genre, 
        img: this.img
      }}
    );
    }

}
 