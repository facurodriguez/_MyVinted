import { TestBed } from '@angular/core/testing';

import { Messenger } from './messenger.service';

describe('MessengerService', () => {
  let service: Messenger;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Messenger);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
