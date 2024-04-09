import { LibraryManagementSystemTemplatePage } from './app.po';

describe('LibraryManagementSystem App', function() {
  let page: LibraryManagementSystemTemplatePage;

  beforeEach(() => {
    page = new LibraryManagementSystemTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
