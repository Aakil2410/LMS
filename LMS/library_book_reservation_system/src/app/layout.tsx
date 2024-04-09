import Footer from "../../components/footer/page";
import Header from "../../components/header/page";
import Navbar from "../../components/navbar/page";

export const metadata = {
  title: "Book Finder",
  description: "Library Book Finder",
};

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en">
      <body>
        <div className="container">
          {children}
        </div>
      </body>
    </html>
  );
}
