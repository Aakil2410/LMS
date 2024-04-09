export const metadata = {
  title: 'LMS',
  description: 'LMS',
}

export default function RootLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <html lang="en">
      <body>
       {children}
        </body>
    </html>
  )
}
