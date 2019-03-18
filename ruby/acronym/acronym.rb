module Acronym
  def self.abbreviate(phrase)
    acronym=""

    phrase = phrase.split(' ')
    phrase.each do |word|
      acronym+= word[0]
    end
    acronym
  end
end
