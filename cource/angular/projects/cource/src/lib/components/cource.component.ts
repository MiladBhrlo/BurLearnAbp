import { Component, OnInit } from '@angular/core';
import { CourceService } from '../services/cource.service';

@Component({
  selector: 'lib-cource',
  template: ` <p>cource works!</p> `,
  styles: [],
})
export class CourceComponent implements OnInit {
  constructor(private service: CourceService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
